using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Pago_BD
    {
        string cc = User.cad;
        SqlConnection CX;
        string cad;
        SqlDataAdapter da;
        SqlCommand con;
        DataTable dt;
        Persona_BD p = new Persona_BD();
        public void NEW_Payment(string name, string balance, string payment, string remaining, string date, string reason)
        {
            int id_client = Client_ID(name);
            try
            {
                String head = "";
                head = "INSERT INTO PAGO VALUES (";


                CX = new SqlConnection(cc);

                cad = head +
                       id_client + ", '" +
                       date + "'," +
                       balance + "," +
                       payment + "," +
                       remaining + ",'" +
                       reason + "')";

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

        public void UPDATE_Payment(string balance, string payment, string remaining,
                                    string name)
        {

            int Id_client = Client_ID(name);
            try
            {

                cad = "UPDATE PAGO " +
                        "SET MONTO='" + balance + "',PAGO='" + payment + "',SALDO='" + remaining +
                        "' WHERE ID_PACIENTE=" + Id_client;

                CX = new SqlConnection(cc);
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

        public int Client_ID(string name)
        {
            int r = 0;
            try
            {
                CX = new SqlConnection(cc);
                cad = "SELECT ID_PACIENTE FROM PACIENTE WHERE NOMBRE = '" + name + "'";
                //con = new SqlCommand(cad, CX);
                CX.Open();
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                DataRow row = dt.Rows[0];

                r = Convert.ToInt32(row["ID_PACIENTE"]);

                CX.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return r;
        }
        public int Payment_ID(string name, string reason)
        {
            int r = 0;
            int id = Client_ID(name);
            try
            {
                CX = new SqlConnection(cc);
                cad = "SELECT ID_PAGO FROM PAGO WHERE ID_PACIENTE="
                    + id + " AND MOTIVO ='" + reason + "'";
                //con = new SqlCommand(cad, CX);
                CX.Open();
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                DataRow row = dt.Rows[0];

                r = Convert.ToInt32(row["ID_PAGO"]);

                CX.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return r;
        }

        public void Get_Client_Data(string name, TextBox tb_id, TextBox tb_balance,
            TextBox tb_aPaid, TextBox tb_remBalance,ComboBox cb_reason, DateTimePicker dtp)
        {
            int id = Client_ID(name);

            try
            {
                CX = new SqlConnection(cc);
                cad = "SELECT * FROM PAGO WHERE ID_PACIENTE=" + id + " AND MOTIVO='" + cb_reason.Text + "'";
                CX.Open();
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                try
                {
                    DataRow row = dt.Rows[0];
                    tb_id.Text = row["ID_PAGO"].ToString();
                    dtp.Text = row["FECHA"].ToString();
                    tb_balance.Text = row["SALDO"].ToString();
                    //tb_aPaid.Text = "";
                    tb_remBalance.Text = Convert.ToString((double)row["SALDO"] - (double)row["PAGO"]);
                    cb_reason.Text = row["MOTIVO"].ToString();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message);

                }


                CX.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public string[] Search_ArrayOfReasons(int id_persona)
        {
            try
            {
                //Recupera el número de personas para despúes asignarle ese tamaño al arreglo estático nombres.
                int size = 0;
                CX = new SqlConnection(cc);
                cad = "select count(*) from PAGO where ID_PACIENTE =" + id_persona;
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                    size = Convert.ToInt32(dt.Rows[0][0].ToString());

                //Destruir objetos para después poder volverlos a crear
                da = null;
                dt = null;

                //Asocia los nombres de las personas al arreglo nombres
                string[] nombres = new string[size];
                cad = "select MOTIVO from PAGO where ID_PACIENTE ="+id_persona;
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                        nombres[i] = dt.Rows[i][0].ToString();
                }
                CX.Close();
                //Se retorna el arreglo nombres ya con los nombres asociados.
                return nombres;
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
                return new string[0];
            }
        }
        public void DELETE_Payment(string id)
        {

            try
            {
                cad = "DELETE FROM PAGO WHERE ID_PAGO=" + id;


                CX = new SqlConnection(cc);



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

    }
}