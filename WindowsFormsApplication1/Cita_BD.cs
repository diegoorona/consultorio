﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Cita_BD
    {
        string cc = User.cad;
        SqlConnection CX;
        string cad;
        SqlDataAdapter da;
        SqlCommand con;
        DataTable dt;
        //Search_Appointment
        public void Search_Appointment(ComboBox cb_name)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "select NOMBRE from PACIENTE";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                        cb_name.Items.Add(dt.Rows[i][0].ToString());
                }
                CX.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void Search_Appointments(DataGridView dgv, String name)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "select * from CITA where ID_PACIENTE IN (select ID_PACIENTE from PACIENTE where NOMBRE = '" + name + "')";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    dgv.Rows.Clear();
                    dgv.RowCount = dt.Rows.Count;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        dgv[0, i].Value = dt.Rows[i][0].ToString();
                        dgv[1, i].Value = dt.Rows[i][1].ToString();
                        dgv[2, i].Value = dt.Rows[i][2].ToString();
                        dgv[3, i].Value = dt.Rows[i][3].ToString();
                        dgv[4, i].Value = dt.Rows[i][4].ToString();
                    }
                }
                CX.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void INSERT_Appointment(String id_secre, String id_patient, String date,
                                 String description)
        {
            try
            {
                String head = "";
                head = "INSERT INTO CITA (ID_SECRETARIA,ID_PACIENTE,FECHA,DESCRIPCION)" +
                         "VALUES ( " + id_secre + ",'";
                CX = new SqlConnection(cc);

                cad = head +
                       id_patient + "', '" +
                       date + "', '" +
                       description + "')";
                con = new SqlCommand(cad, CX);
                CX.Open();
                con.ExecuteNonQuery();
                CX.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool UPDATE_Appointment(String id_appoint, String id_secre, String id_patient, String date,
                                 String description)
        {
            try
            {
                var result = MessageBox.Show("UPDATE CITA WITH ID = " + id_appoint
                    , "CONFIRMATION", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    String head = "";
                    head = "UPDATE CITA SET FECHA = '" + date + "', ";
                    CX = new SqlConnection(cc);
                    cad = head +
                            "DESCRIPCION = '" + description + "'" +
                           " WHERE ID_CITAS = " + id_appoint;
                    con = new SqlCommand(cad, CX);
                    CX.Open();
                    con.ExecuteNonQuery();
                    CX.Close();
                    return true;
                }
                else
                    return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DEL_Appointment(String ID)
        {
            try
            {
                var result = MessageBox.Show("DELETE CITA WITH ID = " + ID
                    , "CONFIRMATION", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CX = new SqlConnection(cc);
                    cad = "DELETE CITA WHERE ID_CITAS = " + ID;
                    con = new SqlCommand(cad, CX);
                    CX.Open();
                    con.ExecuteNonQuery();
                    CX.Close();
                    return true;
                }
                else
                    return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool Vacio_Appointment(String secretary, String patient, String name, String date,
                                 String description)
        {
            bool flag = false;
            if (secretary != "" && patient != "" && name != "" && date != "" && 
                description != "")
            {
                flag = true;
            }
            return flag;
        }
    }
}

