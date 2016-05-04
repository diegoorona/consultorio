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
    class Persona_BD
    {
        string cc = "Data Source=Diego-PC;Initial Catalog=Consultorio_Dental;Integrated Security=True";
        SqlConnection CX;
        string cad;
        SqlDataAdapter da;
        SqlCommand con;
        DataTable dt;
        
        public string[] Search_ArrayOfNames(string Person)
        {
            try
            {
                //Recupera el número de personas para despúes asignarle ese tamaño al arreglo estático nombres.
                int size = 0; 
                CX = new SqlConnection(cc);
                cad = "select count(*) from " + Person.ToUpper();
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
                cad ="select NOMBRE from " + Person.ToUpper();
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
        public void Search_Name(string Person, ComboBox cb_name)
        {
            try
            {
                    CX = new SqlConnection(cc);
                    cad = "select NOMBRE from "+Person.ToUpper();
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
        public void Search_Persona(string Person, String name, Label lID)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "select * from " + Person.ToUpper()+" where NOMBRE = '"+name+"'";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    lID.Text = dt.Rows[0][0].ToString();
                }
                CX.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void INSERT_Person(String Person,String id_card,String name, String gender, String date,
                                 String address, String phone, String email)
        {
            try
            {
                String head = "";
                if (Person == "DENTIST")
                    head = "INSERT INTO " + Person.ToUpper() + " (CEDULA,NOMBRE,SEXO,NACIMIENTO,DIRECCION,TELEFONO,EMAIL)"+
                             "VALUES ( "+id_card+",'";
                else
                    head = "INSERT INTO " + Person.ToUpper() + " (NOMBRE,SEXO,NACIMIENTO,DIRECCION,TELEFONO,EMAIL)"+
                        "VALUES ( '";
                CX = new SqlConnection(cc);
               
                 cad =  head+
                        name + "', '" +
                        gender + "', '" +
                        date + "', '" +
                        address + "', '" +
                        phone + "', '" +
                        email + "')";
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
        public void USER_PASS(String Person,String ID, String User, String Pass)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "UPDATE "+Person.ToUpper()+" SET "+
                       "USUARIO = '"+User+"', "+
                       "PSW = '"+Pass+"' "+
                       "WHERE ID_"+Person.ToUpper()+" = "+ID;
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
        public void UPDATE_Person(String Person,String id_card, String name, String gender, String date,
                                 String address, String phone, String email, String ID)
        {
            try
            {
                String head = "";
                if (Person == "DENTIST")
                    head = "UPDATE " + Person.ToUpper() + " SET CEDULA = "+id_card+", ";
                else
                    head = "UPDATE " + Person.ToUpper() + " SET ";
                CX = new SqlConnection(cc);
                cad =   head +
                        "NOMBRE = '"+name+"', "+
                        "SEXO = '"+gender+"', "+
                        "NACIMIENTO = '"+date+"', "+
                        "DIRECCION = '"+address+"', "+
                        "TELEFONO = '"+phone+"', "+
                        "EMAIL = '"+email+"' "+
                       "WHERE ID_" + Person.ToUpper() + " = " + ID;
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
        public void DEL_Person(String ID,String Person)
        {
            try
            {
                var result = MessageBox.Show("DELETE "+Person.ToUpper()+" WITH ID = "+ID
                    , "CONFIRMATION", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    CX = new SqlConnection(cc);
                    cad = "DELETE " + Person.ToUpper() +
                          " WHERE ID_" + Person.ToUpper() + " = " + ID;
                    con = new SqlCommand(cad, CX);
                    CX.Open();
                    con.ExecuteNonQuery();
                    CX.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool Vacio_Person(String Person, String id_card, String name, String gender, String date,
                                 String address, String phone, String email)
        {
            bool flag = false;
            if (name != "" && gender != "" && date != "" && address != "" &&
                phone != "" && email != "")
            {
                if (Person == "DENTIST")
                {
                    if (id_card != "")
                        flag =true;
                }
                else
                    flag = true;
            }
            return flag;
        }
        public bool Confirm_Contra(String psw1, String psw2)
        {
            bool flag = true;
            if (psw1.Length == psw2.Length)
            {
                for (int i = 0; i < psw1.Length; i++)
                {
                    if (psw1[i] != psw2[i])
                    {
                        flag = false;
                        break;
                    }
                }
            }
            else
                flag = false;
            return flag;
        }
    }
}
