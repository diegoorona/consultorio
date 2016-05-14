using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace WindowsFormsApplication1
{
    class Record_BD
    {
        string cc = User.cad;
        SqlConnection CX;
        string cad;
        SqlDataAdapter da;
        SqlCommand con;
        DataTable dt;
        public void SearchByPatient(string name, ref string file)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "SELECT ARCHIVO FROM EXPEDIENTE " +
                      "WHERE ID_PACIENTE IN (SELECT ID_PACIENTE FROM PACIENTE "+
                                             "WHERE NOMBRE = '"+name+"')";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    file = dt.Rows[0][0].ToString();
                }
                CX.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void SearchByDentist(string name, DataGridView dgv)
        {
            try{
                CX = new SqlConnection(cc);
                cad = "SELECT EX.ID_EXP, P.NOMBRE FROM EXPEDIENTE EX "+
                       "JOIN PACIENTE P ON P.ID_PACIENTE = EX.ID_PACIENTE "+
                       "WHERE P.ID_DENTISTA IN "+
                       "(SELECT ID_DENTISTA FROM DENTISTA WHERE NOMBRE = '"+name+"')";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                dgv.Rows.Clear();
                if (dt.Rows.Count != 0)
                {
                    for (int i =0 ; i < dt.Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv[0, i].Value = dt.Rows[i][0].ToString();
                        dgv[1, i].Value = dt.Rows[i][1].ToString();
                    }
                }
                CX.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void SearchById( string name, ref string id)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "SELECT ID_EXP FROM EXPEDIENTE " +
                       "WHERE ID_PACIENTE IN ( SELECT ID_PACIENTE FROM PACIENTE WHERE NOMBRE = '" + name + "')";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    id = dt.Rows[0][0].ToString();
                }
                CX.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void DeleteRecord(string name, string root , string id)
        {
            try
            {
                var result = MessageBox.Show("DELETE " + name.ToUpper() + " FILE"
                    , "CONFIRMATION", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    CX = new SqlConnection(cc);
                    cad = "DELETE EXPEDIENTE WHERE ID_EXP = "+id;
                    con = new SqlCommand(cad, CX);
                    CX.Open();
                    con.ExecuteNonQuery();
                    CX.Close();
                    System.IO.File.Delete(@root);
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void InsertRecord(string id, string root)
        {
            try
            {
                    CX = new SqlConnection(cc);
                    cad = "INSERT INTO EXPEDIENTE VALUES ("+id+",'"+root+"', GETDATE()) ";
                    con = new SqlCommand(cad, CX);
                    CX.Open();
                    con.ExecuteNonQuery();
                    CX.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public bool Exist (string name)
        {
            bool flag = true;
            try
            {
                CX = new SqlConnection(cc);
                cad = "SELECT ID_EXP FROM EXPEDIENTE " +
                       "WHERE ID_PACIENTE IN ( SELECT ID_PACIENTE FROM PACIENTE WHERE NOMBRE = '" + name + "')";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    flag = true;
                }
                else
                    flag = false;
                CX.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
            return flag;
        }

    }
}
