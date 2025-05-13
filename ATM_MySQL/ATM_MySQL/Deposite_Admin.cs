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
    public partial class Deposite_Admin : Form
    {
        public Deposite_Admin()
        {
            InitializeComponent();
        }

        Functions_RelatedBalance frb = new Functions_RelatedBalance();

        private void button3_Click(object sender, EventArgs e)
        {
            if(accid_deposite.Text == "")
            {
                MessageBox.Show("Enter Account ID");
            }
            else
            {
                int accid_dep = int.Parse(accid_deposite.Text);
                frb.Show_Balance(accid_dep);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard ad = new Admin_Dashboard();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (accid_deposite.Text == "" || amount_deposite.Text == "")
            {
                MessageBox.Show("Enter Account ID & Amount");
            }
            else
            {
                int accid_dep = int.Parse(accid_deposite.Text);
                double amount = double.Parse(amount_deposite.Text);

                bool result = frb.DepositAmount(accid_dep, amount);

                if (result)
                {
                    MessageBox.Show("Amount deposited successfully.");
                    this.amount_deposite.Text = "";

                }
                else
                {
                    MessageBox.Show("Failed to deposit amount.");
                }
            }
            
        }
    }
}
