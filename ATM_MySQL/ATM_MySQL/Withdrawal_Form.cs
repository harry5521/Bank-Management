using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_MySQL
{
    public partial class Withdrawal_Form : Form
    {
        public Withdrawal_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard_Form df = new Dashboard_Form();
            df.Show();
            this.Hide();
        }
    }
}
