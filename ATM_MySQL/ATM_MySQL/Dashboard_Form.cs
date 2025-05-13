using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_MySQL
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Withdrawal_Form wf = new Withdrawal_Form();
            wf.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout your Account", "Logout", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Login_form login = new Login_form();
                login.Show();
                this.Hide();
            }
            
        }
    }
}
