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
        string cc = User.cad;
        SqlConnection CX;
        string cad;
        SqlDataAdapter da;
        SqlCommand con;
        DataTable dt;
        public string TypeOfUser(String User, String Psw)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "select NOMBRE from DENTISTA where USUARIO = '" + User + "' AND PSW='" + Psw + "'";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    return "DENTIST";
                }
                else
                {
                    cad = "select NOMBRE from SECRETARIA where USUARIO = '" + User + "' AND PSW='" + Psw + "'";
                    da = null;
                    dt = null;
                    da = new SqlDataAdapter(cad, CX);
                    dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        return "SECRETARY";
                    }
                }
                CX.Close();
                return "";
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
                return "";
            }
        }
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
        public void Searh_ID(string Person, string name, Label id)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "select ID_" + Person.ToUpper() + " from " + Person.ToUpper() +
                    " WHERE NOMBRE = '" + name + "'";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    id.Text = dt.Rows[0][0].ToString();
                }
                CX.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
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
        private void Search_Dentist(DataTable dt, TextBox name, Label id, TextBox cedula, ComboBox sexo,
                                  DateTimePicker date, TextBox dir, TextBox tel, TextBox email)
        {
            id.Text = dt.Rows[0][0].ToString();
            cedula.Text = dt.Rows[0][1].ToString();
            name.Text = dt.Rows[0][2].ToString();
            sexo.Text = dt.Rows[0][3].ToString().Trim();
            date.Text = Convert.ToDateTime(dt.Rows[0][4]).ToShortDateString();
            dir.Text = dt.Rows[0][5].ToString();
            tel.Text = dt.Rows[0][6].ToString();
            email.Text = dt.Rows[0][7].ToString();
        }
        public void Search_Dentist_Patient(ComboBox cbName, string id)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "select NOMBRE FROM DENTISTA" +
                       " where ID_DENTISTA in (select ID_DENTISTA from PACIENTE where ID_PACIENTE = " + id + ")";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    cbName.Text = dt.Rows[0][0].ToString();
                }
                CX.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void Search_Persona(string Person, TextBox name, Label id, TextBox cedula, ComboBox sexo,
                                    DateTimePicker date, TextBox dir, TextBox tel, TextBox email, string nombre)
        {
            try
            {
                string query = "SELECT ID_" + Person.ToUpper() + ", NOMBRE, SEXO,NACIMIENTO," +
                               "DIRECCION,TELEFONO, EMAIL FROM " + Person.ToUpper();
                if (Person == "DENTISTA")
                    query = "SELECT ID_" + Person.ToUpper() + ", CEDULA, NOMBRE, SEXO,NACIMIENTO," +
                               "DIRECCION,TELEFONO, EMAIL FROM " + Person.ToUpper();
                CX = new SqlConnection(cc);
                cad = query + " WHERE NOMBRE = '" + nombre + "'";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    if (Person == "DENTISTA")
                    {
                        this.Search_Dentist(dt, name, id, cedula, sexo, date, dir, tel, email);
                    }
                    else
                    {
                        id.Text = dt.Rows[0][0].ToString();
                        name.Text = dt.Rows[0][1].ToString();
                        sexo.Text = dt.Rows[0][2].ToString().Trim();
                        date.Text = Convert.ToDateTime(dt.Rows[0][3]).ToShortDateString();
                        dir.Text = dt.Rows[0][4].ToString();
                        tel.Text = dt.Rows[0][5].ToString();
                        email.Text = dt.Rows[0][6].ToString();
                    }

                }
                CX.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void Dentist_Patient(string id_dentista, string id_paciente)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "UPDATE PACIENTE SET ID_DENTISTA = " + id_dentista + " WHERE ID_PACIENTE = " + id_paciente;
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
        public void INSERT_Person(String Person,String id_card,String name, String gender, String date,
                                 String address, String phone, String email)
        {
            try
            {
                String head = "";
                if (Person == "DENTISTA")
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
        public void Search_USER_PASS(string Person, TextBox user, TextBox pass, TextBox pass2, string id_person)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "SELECT USUARIO, PSW FROM " + Person.ToUpper() + " WHERE ID_" + Person.ToUpper() + " = " + id_person;
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    user.Text = dt.Rows[0][0].ToString();
                    pass.Text = dt.Rows[0][1].ToString();
                    pass2.Text = dt.Rows[0][1].ToString();
                }
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
        public string Access(String User, String Psw)
        {
            try
            {
                string nombre = "";
                CX = new SqlConnection(cc);
                cad = "select NOMBRE from DENTISTA where USUARIO = '" + User + "' AND PSW='" + Psw + "'";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    nombre = dt.Rows[0][0].ToString();
                }
                else
                {
                    cad = "select NOMBRE from SECRETARIA where USUARIO = '" + User + "' AND PSW='" + Psw + "'";
                    da = null;
                    dt = null;
                    da = new SqlDataAdapter(cad, CX);
                    dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        nombre = dt.Rows[0][0].ToString();
                    }
                }
                CX.Close();
                return nombre;
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
                return "";
            }
        }

        public void DentistList(DataGridView dgv, string Person, string id)
        {
            try
            {
                CX = new SqlConnection(cc);
                if(Person == "DENTISTA")
                    cad = "SELECT ID_DENTISTA, NOMBRE FROM DENTISTA";       
                else if (Person == "SECRETARIA")
                    cad = "SELECT ID_DENTISTA,NOMBRE FROM DENTISTA "+
                          "WHERE ID_DENTISTA IN (SELECT ID_DENTISTA FROM DENTISTA_SECRETARIA "+
					      "WHERE ID_SECRETARIA = "+id+")";
                da = new SqlDataAdapter(cad, CX);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    dgv.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgv.Rows.Add();
                        dgv[0, i].Value = dt.Rows[i][0].ToString();
                        dgv[1, i].Value = dt.Rows[i][1].ToString();
                    }
                }
                CX.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void INSERT_DENTIST_SERETARY(string ID_DENTISTA, string ID_SECRETARIA)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "INSERT INTO DENTISTA_SECRETARIA VALUES ("+ID_DENTISTA+","+ID_SECRETARIA+")";
                con = new SqlCommand(cad, CX);
                CX.Open();
                con.ExecuteNonQuery();
                CX.Close();
                MessageBox.Show("A DENTISTS SECRETARY RELATION HAS BEEN INSERTED.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DELETE_DENTIST_SERETARY(string ID_DENTISTA, string ID_SECRETARIA)
        {
            try
            {
                CX = new SqlConnection(cc);
                cad = "DELETE DENTISTA_SECRETARIA WHERE ID_DENTISTA = " + ID_DENTISTA + " AND ID_SECRETARIA = " + ID_SECRETARIA ;
                var result = MessageBox.Show("YOU ARE ABOUT TO DELETE THIS RELATION"
                                            , "CONFIRMATION", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    con = new SqlCommand(cad, CX);
                    CX.Open();
                    con.ExecuteNonQuery();
                    CX.Close();

                    MessageBox.Show("A DENTISTS SECRETARY RELATION HAS BEEN DELETED.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
