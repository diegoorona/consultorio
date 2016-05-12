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
        public RECORDS()
        {
            InitializeComponent();
            toolStripMenuItem1.Text = User.NameOfUser;
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
    }
}
