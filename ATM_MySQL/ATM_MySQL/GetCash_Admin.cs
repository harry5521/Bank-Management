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
    public partial class GetCash_Admin : Form
    {
        public GetCash_Admin()
        {
            InitializeComponent();
        }

        Functions_RelatedBalance frb = new Functions_RelatedBalance();
        Functions_DB fd = new Functions_DB();

        private void button4_Click(object sender, EventArgs e)
        {
            if (accid_getcash.Text == "")
            {
                MessageBox.Show("Enter Account ID");
            }
            else
            {
                int accid_get = int.Parse(accid_getcash.Text);
                frb.Show_Balance(accid_get);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fd.LoadData(dataGridView_getcash, "bank_account");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard ad = new Admin_Dashboard();
            ad.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (accid_getcash.Text == "" || amount_getcash.Text == "" || bankid_getcash.Text == "")
            {
                MessageBox.Show("Fill all fields");
            }
            else
            {
                int accid_get = int.Parse(accid_getcash.Text);
                int amount_get = int.Parse(amount_getcash.Text);
                int bankid_get = int.Parse(bankid_getcash.Text);

                bool result = frb.TransferToBank(accid_get, amount_get, bankid_get);
                if (result)
                {
                    MessageBox.Show("Cash Transfered successfully.");
                    this.accid_getcash.Text = "";
                    this.amount_getcash.Text = "";
                    this.bankid_getcash.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to Transfer Cash.");
                }

            }
        }
    }
}
