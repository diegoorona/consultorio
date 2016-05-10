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
    public partial class PAYMENT : Form
    {
        string operacion = "";
        double val;
        double val2;
        Pago_BD pago = new Pago_BD();
        Persona_BD paciente = new Persona_BD();
        public PAYMENT()
        {
            InitializeComponent();
            tb_id.Enabled = false;
            tb_curBalance.Enabled = false;
            tb_amountPaid.Enabled = false;
            tb_reBalance.Enabled = false;
            dateTimePicker1.Enabled = false;
            bt_pay.Enabled = false;
            bt_search.Visible = false;
        }
        private bool isNumeric(String num)
        {
            double n;
            return double.TryParse(num, out n);

        }
        private void Clearall()
        {
            cb_name.Text = "";
            tb_id.Clear();
            tb_curBalance.Clear();
            tb_amountPaid.Clear();
            tb_reBalance.Clear();
            cb_reason.Text = "";
        }
        private void Autocompletar()
        {
            string[] list;

            //Regresa un arreglo estático con todos los nombres de la tabla Paciente para después asociarlos al combobox para que
            //estén disponibles en el autocompletado.
            list = paciente.Search_ArrayOfNames("PACIENTE");

            var source = new AutoCompleteStringCollection();
            source.AddRange(list);

            cb_name.AutoCompleteCustomSource = source;
            cb_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void Autocompletar2()
        {
            string[] list;

            //Regresa un arreglo estático con todos los nombres de la tabla Paciente para después asociarlos al combobox para que
            //estén disponibles en el autocompletado.
            list = pago.Search_ArrayOfReasons(pago.Client_ID(cb_name.Text));

            var source = new AutoCompleteStringCollection();
            source.AddRange(list);

            cb_reason.AutoCompleteCustomSource = source;
            cb_reason.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_reason.AutoCompleteSource = AutoCompleteSource.CustomSource;
            for (int i = 0; i < list.Length; i++)
            {
                cb_reason.Items.Add(list.GetValue(i));

            }


        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            tb_amount.Text += "0";
        }

        private void bt_point_Click(object sender, EventArgs e)
        {
            tb_amount.Text += ".";
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            tb_amount.Text += "1";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            tb_amount.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            tb_amount.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            tb_amount.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            tb_amount.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            tb_amount.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            tb_amount.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            tb_amount.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            tb_amount.Text += "9";
        }

        private void bt_equal_Click(object sender, EventArgs e)
        {
            val2 = Convert.ToDouble(tb_amount.Text);
            switch (operacion)
            {

                case "+":
                    tb_amount.Text = Convert.ToString(val + val2);
                    break;
                case "-":
                    tb_amount.Text = Convert.ToString(val - val2);
                    break;
                case "*":
                    tb_amount.Text = Convert.ToString(val * val2);
                    break;
                case "/":
                    tb_amount.Text = Convert.ToString(val / val2);
                    break;
            }
            val = Convert.ToDouble(tb_amount.Text);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            operacion = "+";
            val = Convert.ToDouble(tb_amount.Text);
            tb_amount.Clear();
        }

        private void bt_sub_Click(object sender, EventArgs e)
        {
            operacion = "-";
            val = Convert.ToDouble(tb_amount.Text);
            tb_amount.Clear();
        }

        private void bt_times_Click(object sender, EventArgs e)
        {
            operacion = "*";
            val = Convert.ToDouble(tb_amount.Text);
            tb_amount.Clear();
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            operacion = "/";
            val = Convert.ToDouble(tb_amount.Text);
            tb_amount.Clear();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_amount.Clear();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            pago.Get_Client_Data(cb_name.Text, tb_id, tb_curBalance,
                 tb_amountPaid, tb_reBalance, cb_reason, dateTimePicker1);
            tb_amountPaid.Enabled = true;
            bt_pay.Enabled = true;
        }

        private void tb_curBalance_TextChanged(object sender, EventArgs e)
        {
            if (cb_option.SelectedIndex == 0)
            {
                tb_amountPaid.Enabled = true;
            }
        }

        private void tb_amountPaid_TextChanged(object sender, EventArgs e)
        {
            double Resultado = 0;

            if (isNumeric(tb_curBalance.Text) && isNumeric(tb_amountPaid.Text))
            {
                double cant1 = Convert.ToDouble(tb_curBalance.Text);
                double cant2 = Convert.ToDouble(tb_amountPaid.Text);
                Resultado = cant1 - cant2;
            }
            else
                tb_reBalance.Clear();

            tb_reBalance.Text = Resultado.ToString();

            try
            {

                if (Convert.ToDouble(tb_amountPaid.Text) < 0 && tb_amountPaid.Text != "")
                    tb_amountPaid.Text = "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type a Number", ex.Message);
            }

            if (Convert.ToDouble(tb_reBalance.Text) < 0)
            {
                MessageBox.Show("Invalid amount of money");
                tb_amountPaid.Text = "1";
            }
        }

        private void bt_pay_Click(object sender, EventArgs e)
        {
            if (tb_amountPaid.Text == "" || cb_name.Text == "" ||
               tb_curBalance.Text == "" || tb_reBalance.Text == "" || cb_reason.Text == "")
            {
                MessageBox.Show("Missing fields!!");
                return;
            }

            if (cb_option.SelectedIndex == 0)
            {
                DialogResult result = MessageBox.Show("Do you want to proceed?", "Alert!!", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    pago.NEW_Payment(cb_name.Text, tb_curBalance.Text, tb_amountPaid.Text,
                        tb_reBalance.Text, dateTimePicker1.Value.ToShortDateString(), cb_reason.Text);
                    MessageBox.Show("Transaction completed.");
                }
                else
                    MessageBox.Show("Transaction not completed.");
            }
            if (cb_option.SelectedIndex == 1)
            {
                DialogResult result = MessageBox.Show("Do you want to proceed?", "Alert!!", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    pago.UPDATE_Payment(tb_curBalance.Text, tb_amountPaid.Text, tb_reBalance.Text, cb_name.Text);
                    MessageBox.Show("Transaction completed.");

                }
                else
                    MessageBox.Show("Transaction not completed.");

                pago.Get_Client_Data(cb_name.Text, tb_id, tb_curBalance,
                    tb_amountPaid, tb_reBalance, cb_reason, dateTimePicker1);
                tb_amountPaid.Enabled = true;
            }
            if (Convert.ToInt32(tb_curBalance.Text) == 0)
            {
                MessageBox.Show("The loan's paid off");
                int id = pago.Payment_ID(cb_name.Text, cb_reason.Text);
                pago.DELETE_Payment(Convert.ToString(id));
                Clearall();
            }
        }

        private void cb_name_TextChanged(object sender, EventArgs e)
        {
            if (cb_option.SelectedIndex == 0)
            {
                bool habilitado = true;
                if (cb_name.Text != "")
                    habilitado = true;
                else
                    habilitado = false;

                dateTimePicker1.Enabled = habilitado;
                tb_curBalance.Enabled = habilitado;
            }
        }

        private void bt_clearall_Click(object sender, EventArgs e)
        {
            Clearall();
        }

        private void PAYMENT_Load(object sender, EventArgs e)
        {
            Autocompletar();
        }

        private void cb_option_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_option.SelectedIndex == 0)
            {
                Clearall();
                tb_curBalance.Enabled = false;
                tb_amountPaid.Enabled = false;
                tb_reBalance.Enabled = false;
                dateTimePicker1.Enabled = false;
                tb_reBalance.Text = "0.0";
                bt_pay.Enabled = false;
                bt_search.Visible = false;
            }

            if (cb_option.SelectedIndex == 1)
            {
                tb_curBalance.Enabled = false;
                tb_amountPaid.Enabled = false;
                tb_reBalance.Enabled = false;
                dateTimePicker1.Enabled = false;
                bt_pay.Enabled = false;
                bt_search.Visible = true;
                Clearall();

            }
        }

        private void cb_reason_MouseClick(object sender, MouseEventArgs e)
        {
            if (cb_option.SelectedIndex == 1)
            {
                cb_reason.Items.Clear();
                Autocompletar2();
            }
        }

        private void cb_reason_TextChanged(object sender, EventArgs e)
        {
            if (cb_option.SelectedIndex == 0)
                bt_pay.Enabled = true;
        }
    }
}
